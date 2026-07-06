using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{

    [SerializeField] GameObject playerCamPosition;
    [SerializeField] Light batteryLight;
    [SerializeField] TextMeshProUGUI hitCounter;
    private Vector3 lookDirection;
    private int hitCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hitCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // calculate direction vector of player to UI
        if(playerCamPosition != null){
            lookDirection = playerCamPosition.transform.position - transform.position;
            lookDirection.y = 0;
            // using the direction vector - apply rotation to UI
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }

    public void incrementHitCounter(){
        if(hitCount <= 20){
            hitCount++;
            hitCounter.text = hitCount + "/10";
            batteryLight.intensity += 1f;
        }
    }

    public int getHitCount(){
        return hitCount;
    }
}
