using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField] GameObject[] targets;
    private GameObject goal;
    private GameObject start;
    private int goalInt;
    private int startInt;
    private AudioSource goalHit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goalHit = GetComponent<AudioSource>();
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(goal.GetComponent<GridTargetController>().isPowerOn){
            goalHit.Play();
            foreach(GameObject target in targets){
                target.GetComponent<GridTargetController>().powerOff();
                target.SetActive(false);
            }
            StartGame();
        }
    }

    public void StartGame(){
        startInt = -1;
        goalInt = Random.Range(0, targets.Length);
        while(startInt == -1){
            startInt = Random.Range(0, targets.Length);
            if(startInt == goalInt){
                startInt = -1;
            }
        }
        goal = targets[goalInt];
        goal.GetComponent<GridTargetController>().setTarget();
        start = targets[startInt];
        start.GetComponent<GridTargetController>().setStart();
    }
}
