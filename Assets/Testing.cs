using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject BlackHoleObject1;
    

    public float timeBeforeLerp = 5f;
    public float timeBeforeSecondLerp = 5f;

    private bool shouldLerp = false;
    public float timeStartedLerping;

    public float lerpTime;

    public Vector3 endScale;
    public Vector3 startScale;

    public Vector3 Lerp(Vector2 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentageComplete);
        return result;
    }

    private void StartLerping()
    {
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    //private void StartLerpingAgain()
    //{
        //timeStartedLerping = Time.time;
        //shouldLerp = true;
    //}

    // Start is called before the first frame update
    private void Start()
    {
       GradientBorders.Create(FirstAction, timeBeforeLerp);
       //GradientBorders.Create(SecondAction, timeBeforeSecondLerp);
    }

    private void Update()
    {
        if (shouldLerp)
        {
            transform.localScale = Lerp(startScale, endScale, timeStartedLerping, lerpTime);
        }
        
    }

    private void FirstAction()
    {
        StartLerping(); 
    }
    //private void SecondAction()
    //{
        //BlackHoleObject2.SetActive(true);
        //BlackHoleObject1.SetActive(false);
        //StartLerpingAgain();
    //}


}
