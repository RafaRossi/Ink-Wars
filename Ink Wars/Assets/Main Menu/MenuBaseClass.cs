using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class MenuBaseClass : MonoBehaviour
{
    public Action OnMenuLoaded = delegate { };
    public Action OnMenuUnloaded = delegate { };

    protected virtual void Awake()
    {
        
    }

    public void LoadMenu(GameObject menuToLoad)
    {
        gameObject.SetActive(false);

        menuToLoad.gameObject.SetActive(true);
    }

    protected virtual void OnEnable() {
        OnMenuLoaded();
    }
    protected virtual void OnDisable() {
        OnMenuUnloaded();
    }
}
