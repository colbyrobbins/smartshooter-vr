using UnityEngine;

public class GridTargetController : MonoBehaviour
{
    [SerializeField] GameObject[] adjTargets;
    [SerializeField] GameObject crosshairs;
    [SerializeField] GameObject electricSign;
    public bool isPowerOn;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update(){
        foreach(GameObject target in adjTargets){
            if(isPowerOn){
                target.SetActive(true);
            }
        }
    }

    public void powerOn(){
        isPowerOn = true;
        electricSign.SetActive(true);
    }

    public void powerOff(){
        isPowerOn = false;
        electricSign.SetActive(false);
        crosshairs.SetActive(false);
    }

    public void setTarget(){
        crosshairs.SetActive(true);
    }

    public void setStart(){
        gameObject.SetActive(true);
        isPowerOn = true;
        electricSign.SetActive(true);
    }
}
