using UnityEngine;

public class projectileController : MonoBehaviour
{
    private AudioSource hitSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitSound = GetComponent<AudioSource>();
        Destroy(gameObject, 3);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target"){
            hitSound.Play();
            FindAnyObjectByType<UIController>().incrementHitCounter();
            if(FindAnyObjectByType<UIController>().getHitCount() == 10){
                FindAnyObjectByType<DoorController>().openDoors();
            }
            collision.gameObject.SetActive(false);
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "GridTarget"){
            collision.gameObject.GetComponent<GridTargetController>().powerOn();
            Destroy(gameObject);
        }
    }
}
