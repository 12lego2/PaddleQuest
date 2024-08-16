using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource SFX;
    public AudioClip confirm; //button confirm
    public AudioClip block;
    public AudioClip damage;

    //repeat for different sound effects for different buttons
    public void sfxButtonConfirm()
    {
        SFX.clip = confirm;
        SFX.Play();
    }

    public void sfxBlock()
    {
        SFX.clip = block;
        SFX.Play();
    }
    public void sfxDamage()
    {
        SFX.clip = damage;
        SFX.Play();
    }

    // Start is called before the first frame update
    // void Start()
    // {
    //     
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     
    // }
}
