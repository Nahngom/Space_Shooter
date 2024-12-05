using UnityEngine;

public class GameController : MonoBehaviour
{
    //public float Total_Astroid_Destroyed = 0;
    public AudioClip gameAudio;
    private AudioSource gameAudioSource;
    void Start()
    {
        gameAudioSource = gameObject.AddComponent<AudioSource>();
        gameAudioSource.clip = gameAudio;
        gameAudioSource.playOnAwake = true;
        //gameAudioSource.volume = ;
        gameAudioSource.loop = true;
        gameAudioSource.volume = 0.1f;
        gameAudioSource.Play();
    }
    //public float getTotal_Astroid_Destroyed() { 
    //return Total_Astroid_Destroyed;
    //}
    
}
