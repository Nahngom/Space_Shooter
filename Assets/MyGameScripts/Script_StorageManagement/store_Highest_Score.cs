using UnityEngine;
using System.IO;
public class store_Highest_Score : MonoBehaviour
{
    private string filepath;
    private void Start()
    {
        filepath = Application.persistentDataPath + "/highscore.json";// Application.presistantDataPath is a built in unity property that provides s directory to store file.
                                                                      // "/highscore.json" where highscore.json is the file name where i will be stroing teh score in json formate
                                                                      /*
                                                                        On Windows: C:\Users\<Username>\AppData\LocalLow\<CompanyName>\<GameName>\
                                                                        On Android: /data/data/<package-name>/files/
                                                                        On iOS: Documents/
                                                                       */
        //Debug.Log("file called " + filepath);
    }

    public void Store_Highest_Score(float currentScore) {
       
        float highest_score = LoadHighestScore();

        if (currentScore > highest_score) {
            File.WriteAllText(filepath, currentScore.ToString());
            Debug.Log("highest score saved " + currentScore);
        }
    }

    public float LoadHighestScore() {
        if (File.Exists(filepath)) { 
            string highScoreString = File.ReadAllText(filepath);
            Debug.Log("loaded score " + highScoreString);
            return float.Parse(highScoreString);
        }

        return 0;
    }
}
