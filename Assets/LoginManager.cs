using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    /*cuando el usuario presione el boton aceptar se debe escribir un mensaje en la consola 
           si el texto de inputPassword coincide con la contraseña predeterminada escribir
    "Acess granted"
    Sino escribir "Access denied"
    */
    public InputField ingresodatos;
    public string password = "Contraseña";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ejercicio();
    }

    public void ejercicio()
    {
        if (ingresodatos.text != null){
            if (ingresodatos.text == password)
            {
                Debug.Log("Acess granted");
            }
            else
            {
                Debug.Log("Acess denied");
            }
        }
    }
}
