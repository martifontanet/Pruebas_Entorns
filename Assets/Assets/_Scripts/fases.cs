
using UnityEngine;

public class fases : MonoBehaviour
{
    public float transitionMove = 2f;
    public float transitionGrow = 1f;
    public float transitionWait = 0.5f;
    public Vector3 movePoint;
    private Vector3 scale;
    private Vector3 pos;
    public int multScale = 2;
    bool colorChanged = false;

    float timer;
    float startTime;

    [SerializeField]
    private Transform cylinder;

    // Start is called before the first frame update
    void Start()
    {
        scale = cylinder.transform.localScale;
        pos = cylinder.transform.position;
        startTime = Time.time;
        Debug.Log((transitionGrow * 2) + transitionWait + (transitionMove * 2));
    }
    private void Update()
    {
        timer = Time.time - startTime;
        if (timer <= transitionGrow)
        {
            Creixer();
        }
        else if (timer <= (transitionGrow + transitionWait))
        {
            ChangeColor();
        }
        else if (timer <= ((transitionGrow  * 2) + transitionWait))
        {
            Decreixer();
        }
        else if (timer <= ((transitionGrow * 2) + transitionWait + transitionMove))
        {
            Move();
        }
        else if (timer <= ((transitionGrow * 2) + transitionWait + (transitionMove * 2)))
        {
            MoveBack();
        }
    }

    private void MoveBack()
    {
        if(cylinder.transform.position != pos)
        {
            Debug.LogWarning("MoveBack");
            Debug.Log(timer);
            float t = ((timer - (transitionGrow * 2 + transitionWait + transitionMove))) / transitionMove;
            float smoothStep = Mathf.SmoothStep(0f, 1f, t);
            cylinder.transform.position = Vector3.Lerp(cylinder.transform.position, pos, smoothStep);
        }
        else
        {
            Debug.Log(timer);
            Debug.LogWarning("Reset");
            startTime = Time.time;
            colorChanged = false;
        }
    }

    private void Move()
    {
        Debug.LogWarning("Movent");
        float t = ((timer - (transitionGrow * 2 + transitionWait))) / transitionMove;
        float smoothStep = Mathf.SmoothStep(0f, 1f, t);
        cylinder.transform.position = Vector3.Lerp(pos, movePoint, smoothStep);
    }

    private void Decreixer()
    {
        Debug.LogWarning("Decreixent");
        cylinder.transform.localScale = Vector3.Lerp(cylinder.transform.localScale, scale, timer-1.5f);
    }

    private void ChangeColor()
    {
        Debug.LogWarning("Canvi Color");
        if (!colorChanged)
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            cylinder.GetComponent<MeshRenderer>().material.color = randomColor;
            colorChanged = true;
        }
    }

    private void Creixer()
    {
        Debug.LogWarning("Creixent");
        Vector3 xscale = Vector3.Lerp(scale, scale * multScale, timer);
        transform.localScale = xscale;
    }
}
