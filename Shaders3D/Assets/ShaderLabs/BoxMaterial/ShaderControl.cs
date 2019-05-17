using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControl : MonoBehaviour
{

    public Material Section;
    public Material Extrude;
    public float Value;
    public float MaxValue;
    public float MinValue;
    ////private float disolveMax = -1;
    ////private float disolveMin = .5f;
    //public bool Inside = false;

    // Use this for initialization
    void Start()
    {

        Section.SetFloat("_Val", Value);
        Extrude.SetFloat("_Factor", Value);

    }

    // Update is called once per frame
    void Update()
    {
        #region Section
        if (Input.GetKey(KeyCode.W))
        {
            if (Value < MaxValue)
            {
                Value += .25f;
                Section.SetFloat("_Val", Value);

            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (Value > MinValue)
            {
                Value -= .25f;
                Section.SetFloat("_Val", Value);
            }
        }
        #endregion
        #region Extrude
        if (Input.GetKey(KeyCode.Q))
        {
            if (Value < MaxValue)
            {
                Value += .05f;
                Extrude.SetFloat("_Factor", Value);

            }
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (Value > MinValue)
            {
                Value -= .05f;
                Extrude.SetFloat("_Factor", Value);
            }
        }
        #endregion
    }


}

