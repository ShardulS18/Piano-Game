using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [System.Serializable]
    public class NoteInfo
    {
        public string noteName;
        public float timeDelay;
    }

    public List<NoteInfo> melody;
    public Transform c4Spawn, d4Spawn, e4Spawn, f4Spawn, g4Spawn, a4Spawn;
    public GameObject c4NotePrefab, d4NotePrefab, e4NotePrefab, f4NotePrefab, g4NotePrefab, a4NotePrefab;

    void Start()
    {
        StartCoroutine(PlayMelody());
    }

    IEnumerator PlayMelody()
    {
        Debug.Log("Starting melody with " + melody.Count + " notes");
        foreach (NoteInfo note in melody)
        {
            Debug.Log("Waiting " + note.timeDelay + " seconds for note: " + note.noteName);
            yield return new WaitForSeconds(note.timeDelay);

            GameObject spawnedNote = null;

            switch (note.noteName)
            {
                case "C4":
                    Debug.Log("Spawning C4 note");
                    spawnedNote = Instantiate(c4NotePrefab, c4Spawn.position, Quaternion.identity);
                    break;
                case "D4":
                    Debug.Log("Spawning D4 note");
                    spawnedNote = Instantiate(d4NotePrefab, d4Spawn.position, Quaternion.identity);
                    break;
                case "E4":
                    Debug.Log("Spawning E4 note");
                    spawnedNote = Instantiate(e4NotePrefab, e4Spawn.position, Quaternion.identity);
                    break;
                case "F4":
                    Debug.Log("Spawning F4 note");
                    spawnedNote = Instantiate(f4NotePrefab, f4Spawn.position, Quaternion.identity);
                    break;
                case "G4":
                    Debug.Log("Spawning G4 note");
                    spawnedNote = Instantiate(g4NotePrefab, g4Spawn.position, Quaternion.identity);
                    break;
                case "A4":
                    Debug.Log("Spawning A4 note");
                    spawnedNote = Instantiate(a4NotePrefab, a4Spawn.position, Quaternion.identity);
                    break;
            }
            if (spawnedNote == null)
            {
                Debug.LogError("Failed to spawn note: " + note.noteName);
            }
        }
    }
}