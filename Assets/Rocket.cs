using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets
{
    public class Rocket : MonoBehaviour
    {
        //RocketControl control;
        RocketControl control;  
        
        Vector2 move;

        void Awake(){
            control = new RocketControl();

            //control.Gameplay.M
            //control.Gameplay.MoveUp.performed += ctx => MoveUpFunc();
            control.Gameplay.MoveUp.performed += ctx => move = ctx.ReadValue<Vector2>();
            control.Gameplay.MoveUp.canceled += ctx => move = Vector2.zero;
            //control.Gameplay.MoveUp.performed += ctx => MoveUp = ;
            Debug.Log("hello world from update");


        }

        void Update(){
            Debug.Log("hello world from update");
            Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
            transform.Translate(m, Space.World);
        }

        // void MoveUpFunc(){
        //     transform.Translate (1f, 1f, 0f);  
        // }
        //  void MoveDownFunc(){
        //     transform.Translate (-1f, -1f, 0f);  
        // }

        // void OnEnable(){
        //     control.Gameplay.Enable();
        // }

        // void OnDisable(){
        //     control.Gameplay.Disable();
        // }
    }
}