using UnityEngine;

public class DoorController : MonoBehaviour
{
    private AudioSource doorOpenSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        doorOpenSound = GetComponent<AudioSource>();
    }
    public void openDoors(){
        doorOpenSound.Play();
        gameObject.SetActive(false);
    }
}
