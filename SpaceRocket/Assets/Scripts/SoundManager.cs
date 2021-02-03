using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundMan;
    private AudioSource audioSrc;
    private AudioClip[] coinSounds;
    private int randomCoinSound;

    private void Start()
    {
        soundMan = this;
        audioSrc = GetComponent<AudioSource>();
        coinSounds = Resources.LoadAll<AudioClip>("CoinSounds");
    }
    public void PlayCoinSound()
    {
        randomCoinSound = Random.Range(0, 5);
        audioSrc.PlayOneShot(coinSounds[randomCoinSound]);
    }

}
