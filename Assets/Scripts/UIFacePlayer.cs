using UnityEngine;

public class UIFacePlayer : MonoBehaviour
{
    [SerializeField] GameObject playerCamPosition;
    private Vector3 lookDirection;

    // Update is called once per frame
    void Update()
    {
        if(playerCamPosition != null){
            lookDirection = playerCamPosition.transform.position - transform.position;
            lookDirection.y = 0;
            // using the direction vector - apply rotation to UI
            transform.rotation = Quaternion.LookRotation(lookDirection);
        }
    }
}
