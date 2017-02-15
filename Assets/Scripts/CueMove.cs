using UnityEngine;

public class CueMove : MonoBehaviour {
    
    Vector3 dist;
    float posX;
    float posY;

    public float moveSpeed;

    void Start()
    {
       moveSpeed = 1f;
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
    }

    void OnMouseDown()
    {
        dist = Camera.current.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }


    void OnMouseDrag()
    {
        Vector3 MouseCrntPstn = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y, dist.z);
        
        Vector3 ObjPstn = Camera.current.ScreenToWorldPoint(MouseCrntPstn);
        transform.position = ObjPstn;
    }
}
