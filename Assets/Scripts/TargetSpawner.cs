using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] GameObject[] targets;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("createTarget",1,3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void createTarget(){
        if(FindAnyObjectByType<UIController>().getHitCount() < 20){
            int targetIndex = Random.Range(0, targets.Length);
            targets[targetIndex].SetActive(true);
        }
    }
}
