using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{

    private static MusicManager Instance; //make the music manager an instance that can be used anywhere without recreating it
    
    private AudioSource audioSource;

    public AudioClip bgm;

    private void Awake()
    {
        if (Instance == null) // if the music manager was not created yet
        {
            Instance = this; // this instance becomes the music manager
            audioSource = GetComponent<AudioSource>(); // set the code's audio source to the first audio source that can be found from the editor
        }
        else
        {
            Destroy(gameObject); // destroy any instance that is not this one to prevent conflicts
        }
    }
    
    // ↑ pretty nice to see a youtube tutorial put in place a singleton
    // ↑ instead of just doing whatever looks easiest
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (bgm != null)
        {
            PlayBGM(false, bgm);
        }
    }

    public void PlayBGM(bool resetSound, AudioClip clip = null)
    {
        if (clip != null)
        {
            audioSource.clip = clip;
        }
        if (audioSource.clip != null)
        {
            if (resetSound == true)
            {
                audioSource.Stop();
            }
            audioSource.Play();
        }
    }
}
