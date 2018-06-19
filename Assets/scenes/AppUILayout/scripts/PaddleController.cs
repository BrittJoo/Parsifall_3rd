using UnityEngine;
using UnityEngine.EventSystems;

public class PaddleController : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{



//    public float mouse_pos;
//    private bool isdragging;
//    private bool canSnap;
//    [SerializeField] private int snapPoint;
//
//    private bool overMouse;
//
//    public Transform snap1;
//    public Transform snap2;
//    public Transform snap3;
//    public Transform snap4;
//
//    private void Start()
//    {
//    }
//
//    void Update()
//    {
//        Debug.Log(overMouse);
//        overMouse = FindObjectOfType<AcceptChoice>().overMouse;
//
//        if (Input.GetMouseButton(0) && !overMouse)
//        {
//            Vector3 paddle_pos = new Vector3(1f, transform.position.y, 0f);
//            mouse_pos = Input.mousePosition.x / Screen.width * 16;
//            //print(mouse_pos);
//            paddle_pos.x = Mathf.Clamp(mouse_pos, 1, 16.75f); //1f, 12.35f); 
//            paddle_pos.z = 1;
//            this.transform.position = paddle_pos;
//            isdragging = true;
//        }
//
//        if (Input.GetMouseButtonUp(0))
//        {
//            canSnap = true;
//            print("knop los");
//            SnapToPoint();
//        }
//    }
//
//    private void OnMouseOver()
//    {
//        Debug.Log("mouse over");
//    }
//
//    private void OnTriggerEnter2D(Collider2D col)
//    {
//        if (col.transform.GetComponent<EensCollider>())
//        {
//            //point to...
//            snapPoint = 1;
//        }
//
//        if (col.transform.GetComponent<BMECollider>())
//        {
//            //point to...
//            snapPoint = 2;
//        }
//
//        if (col.transform.GetComponent<BMOCollider>())
//        {
//            //point to...
//            snapPoint = 3;
//        }
//
//        if (col.transform.GetComponent<MOCollider>())
//        {
//            //point to...
//            snapPoint = 4;
//        }
//    }
//
//    void SnapToPoint()
//    {
//        if (snapPoint == 1)
//        {
//            //point to...
//            transform.position = snap1.transform.position;
//            print("eensCollider in");
//        }
//
//        if (snapPoint == 2)
//        {
//            //point to...
//            transform.position = snap2.transform.position;
//        }
//
//        if (snapPoint == 3)
//        {
//            //point to...
//            transform.position = snap3.transform.position;
//        }
//
//        if (snapPoint == 4)
//        {
//            //point to...
//            transform.position = snap4.transform.position;
//        }
//    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("On Drag");
        transform.position = new Vector3(eventData.position.x, eventData.position.y);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag");
    }
}