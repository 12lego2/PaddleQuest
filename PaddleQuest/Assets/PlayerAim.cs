using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    public bool canAtk;
    public float timer =0;
    public float AtkCD = 0.6f;
    public float AtkDur = 0.3f;

    public GameObject atkArea;

    void Start()
    {
        //latch on to what is considered main cam; specifically player's cam in the case of cutscene cameras
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        atkArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse location
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        //math for rotation https://www.youtube.com/watch?v=-bkmPm_Besk
        Vector3 rotation = mousePos - transform.position;
        float rotz = Mathf.Atan2(rotation.y, rotation.x) *Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0 , rotz);

        if (!canAtk)
        {
            timer += Time.deltaTime;
            if (timer > AtkDur) { atkArea.SetActive(false); }
            if (timer > AtkCD) { canAtk = true; timer = 0; }
            Debug.Log(timer);
            
        }
        if (Input.GetMouseButton(0) && canAtk == true)
        {
            Debug.Log("Attacked!");
            canAtk = false;
            atkArea.SetActive(true);
        }

    }

    

}
