using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Save.CheckPointPass)
            {
                Save.LastLapTimesMinute = Save.LapTimesMinute;
                Save.LastLapTimesSeconds = Save.LapTimesSeconds;
                Save.LapNumber++;
                Save.LapChange = true;
                if (Save.LapNumber == 2)
                {
                    Save.BestLapTimesMinute = Save.LastLapTimesMinute;
                    Save.BestLapTimesSeconds = Save.LastLapTimesSeconds;
                }
                if (Save.LapNumber==4)
                {
                    SceneManager.LoadScene(4);
                }
            }
        }
    }
}
