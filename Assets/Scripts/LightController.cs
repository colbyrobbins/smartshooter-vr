using UnityEngine;

public class StepController : MonoBehaviour
{
    [SerializeField] GameObject[] lights;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            foreach(GameObject light in lights){
                light.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            foreach(GameObject light in lights){
                light.gameObject.SetActive(false);
            }
        }   
    }
}
