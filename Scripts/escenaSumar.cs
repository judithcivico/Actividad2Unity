using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class escenaSumar : MonoBehaviour
{
	public InputField inputNum1, inputNum2;
    public Text solucion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Sumar()
    {
        float num1, num2;
        string valor1, valor2;
        valor1 = inputNum1.text;
        valor2 = inputNum2.text;
        valor1 = valor1.Replace(".",",");
        valor2 = valor2.Replace(".",",");

       
       /* 
       if(valor1 == "" || valor2 = ""){
            Debug.Log("Debes introducir dos numeros");
        }
        else
        {
        */

        num1 = float.Parse(valor1);
        num2 = float.Parse(valor2);

        float suma = num1 + num2;
        //Debug.Log(valor1 + " " + valor2 + " " + suma);

        solucion.text = suma.ToString();
        }

   public void BackButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
