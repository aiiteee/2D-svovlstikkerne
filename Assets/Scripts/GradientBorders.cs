using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientBorders
{
    public static GradientBorders Create(Action action, float timer)
    {
        GameObject gameObject = new GameObject("GradientBorders", typeof(MonoBehaviourHook));
        GradientBorders gradientBorders = new GradientBorders(action, timer, gameObject);
        gameObject.GetComponent<MonoBehaviourHook>().onUpdate = gradientBorders.Update;

        return gradientBorders;
    }

    public class MonoBehaviourHook : MonoBehaviour
    {
        public Action onUpdate;
        private void Update()
        {
            if (onUpdate != null) onUpdate();
        }

    }

    private Action action;
    private float timer;
    private GameObject GameObject;
    private bool isDestroyed;

    public GradientBorders(Action action, float timer, GameObject gameObject)
    {
        this.action = action;
        this.timer = timer;
        this.GameObject = gameObject;
        isDestroyed = false;
    }
    
    public void Update()
    {
        if (!isDestroyed)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                action();
                DestroySelf();
            }
        }
        
    }

    private void DestroySelf()
    {
        isDestroyed = true;
        UnityEngine.Object.Destroy(GameObject);
    }
}
