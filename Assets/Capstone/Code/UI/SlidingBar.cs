using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlidingBar : MonoBehaviour
     , IPointerClickHandler // 2
     , IDragHandler
     , IPointerEnterHandler
     , IPointerExitHandler
{
    // Starting locations
    public Transform startMarker;
    public Transform endMarker;

    Transform currentPosition;

    // Movement speed in units per second.
    public float speed = 1.0F;

    //Time
    public float time = 1f;

    // Time when the movement started.
    private float startTime;

    // Total distance between the markers.
    private float journeyLength;

    SpriteRenderer sprite;
    Color target = Color.red;

    bool pulledOutBar = false;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Keep a note of the time the movement started.
        startTime = Time.time;

        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    public void Update()
    {
        //if (pulledOutBar == true)
        //{
        //    UpdateBarOutPosition();
        //}

        //if (pulledOutBar == false)
        //{
        //    UpdateBarInPosition();
        //}
    }

    IEnumerator UpdateBarOutPosition(Vector3 source, Vector3 target, float overTime)
    {
        print("wah");
        float startTime = Time.time;
        while (Time.time < startTime + overTime)
        {
            transform.position = Vector3.Lerp(source, target, (Time.time - startTime) / overTime);
            yield return null;
        }
        transform.position = target;
    }

    IEnumerator UpdateBarInPosition(Vector3 source, Vector3 target, float overTime)
    {
        float startTime = Time.time;
        while (Time.time < startTime + overTime)
        {
            transform.position = Vector3.Lerp(source, target, (Time.time - startTime) / overTime);
            yield return null;
        }
        transform.position = target;
    }

    void UpdateBarOutPosition()
    {
        currentPosition = transform;

        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);
    }

    void UpdateBarInPosition()
    {
        currentPosition = transform;

        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(endMarker.position, startMarker.position, fractionOfJourney);
    }

    public void OnPointerClick(PointerEventData eventData) // 3
    {
        print("I was clicked");
        target = Color.blue;

        pulledOutBar = !pulledOutBar;

        currentPosition = transform;

        if (pulledOutBar == true)
            StartCoroutine(UpdateBarOutPosition(startMarker.position, endMarker.position, startTime));
        else
            StartCoroutine(UpdateBarInPosition(endMarker.position, startMarker.position, startTime));
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("I'm being dragged!");
        target = Color.magenta;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        target = Color.green;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        target = Color.red;
    }
}
