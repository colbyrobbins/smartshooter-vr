using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject projectileSpawnPoint;
    float projectileSpeed = 50;
    private AudioSource gunSound;
    bool isPlayerHoldingGun = false;
    [SerializeField] InputActionReference triggerBTNGun;
    private Vector3 initialPosition;

    private void OnEnable() {
        if(triggerBTNGun != null){
            triggerBTNGun.action.Enable();
        }
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
        gunSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(triggerBTNGun.action.WasPressedThisFrame()){
            if(isPlayerHoldingGun){
                gunSound.Play();
                fireGun();
              }
        }
    }

    void fireGun(){
        GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.transform.position,
        projectileSpawnPoint.transform.rotation);

        projectile.GetComponent<Rigidbody>().AddForce(projectileSpawnPoint.transform.up * projectileSpeed,
        ForceMode.Impulse);

    }

    public void PlayerHoldingGun(){
        isPlayerHoldingGun = true;
    }

    public void PlayerReleasedGun(){
        isPlayerHoldingGun = false;
    }

    public void resetWeapon(){
        transform.position = initialPosition;
    }
}
