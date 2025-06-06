using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioController : MonoBehaviour
{
    [System.Serializable]
    public class ButtonAudioPair
    {
        public Button button;
        public AudioClip audioClip;
        public string noteName;
        public Collider2D triggerZone;
    }

    public List<ButtonAudioPair> buttonAudioPairs;
    private AudioSource audioSource;
    public int score = 0;

    [Header("UI References")]
    public TextMeshProUGUI scoreText;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();

        // Initialize score display
        UpdateScoreDisplay();

        foreach (ButtonAudioPair pair in buttonAudioPairs)
        {
            if (pair.button != null && pair.audioClip != null)
            {
                ButtonAudioPair capturedPair = pair;
                pair.button.onClick.AddListener(() => {
                    PlayClip(capturedPair.audioClip);
                    CheckAndDestroyNote(capturedPair);
                });
            }
        }
    }

    void PlayClip(AudioClip clip)
    {
        Debug.Log("Playing clip: " + clip.name);
        audioSource.clip = clip;
        audioSource.Play();
    }

    void CheckAndDestroyNote(ButtonAudioPair pair)
    {
        if (pair.triggerZone == null)
        {
            Debug.LogError($"TriggerZone is not assigned for note: {pair.noteName}");
            return;
        }

        Collider2D[] colliders = Physics2D.OverlapBoxAll(
            pair.triggerZone.bounds.center,
            pair.triggerZone.bounds.size,
            0f
        );

        foreach (Collider2D col in colliders)
        {
            NoteBehaviour note = col.GetComponent<NoteBehaviour>();
            if (note != null)
            {
                Debug.Log($"Found note: {note.noteName}, Expected: {pair.noteName}");
                if (note.noteName == pair.noteName)
                {
                    Destroy(col.gameObject);
                    score += 10;
                    UpdateScoreDisplay(); // Update the UI when score changes
                    Debug.Log("Hit! Score: " + score);
                    return;
                }
            }
        }
        Debug.Log("Miss or wrong note");
    }

    // New method to update the score display
    void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
        else
        {
            Debug.LogWarning("Score Text is not assigned in the inspector!");
        }
    }
}