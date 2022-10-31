using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Master : MonoBehaviour
{
    [SerializeField] GameObject balota;
    [SerializeField] Renderer resultado;
    [SerializeField] int num_resutado = 0;

    [SerializeField] int contador_intentos = 5;
    [SerializeField] int contador_buenas;
    [SerializeField] int contador_malas;
    [Header("contadores intento 1")]
    [SerializeField] int contador_rojas1;
    [SerializeField] int contador_verdes1;
    [SerializeField] int contador_azules1;
    [Header("contadores intento 2")]
    [SerializeField] int contador_rojas2;
    [SerializeField] int contador_verdes2;
    [SerializeField] int contador_azules2;
    [Header("contadores intento 3")]
    [SerializeField] int contador_rojas3;
    [SerializeField] int contador_verdes3;
    [SerializeField] int contador_azules3;
    [Header("contadores intento 4")]
    [SerializeField] int contador_rojas4;
    [SerializeField] int contador_verdes4;
    [SerializeField] int contador_azules4;

    [Header("probabilidad")]
    [SerializeField] int rango_probabilidad = 3;

    [Header("intento 1")]
    [SerializeField] TextMeshProUGUI texto_rojas1;
    [SerializeField] TextMeshProUGUI texto_azul1;
    [SerializeField] TextMeshProUGUI texto_verde1;
    [Header("intento 2")]
    [SerializeField] TextMeshProUGUI texto_rojas2;
    [SerializeField] TextMeshProUGUI texto_azul2;
    [SerializeField] TextMeshProUGUI texto_verde2;
    [Header("intento 3")]
    [SerializeField] TextMeshProUGUI texto_rojas3;
    [SerializeField] TextMeshProUGUI texto_azul3;
    [SerializeField] TextMeshProUGUI texto_verde3;
    [Header("intento 4")]
    [SerializeField] TextMeshProUGUI texto_rojas4;
    [SerializeField] TextMeshProUGUI texto_azul4;
    [SerializeField] TextMeshProUGUI texto_verde4;
    [Header("tex")]
    [SerializeField] TextMeshProUGUI texto_intentos;

    [SerializeField] GameObject ganaste;
    [SerializeField] GameObject perdiste;




    bool terminar = false;
    bool verificar = false;
    

    // Start is called before the first frame update
    void Start()
    {
        resultado = balota.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

        texto_rojas1.text = "" + contador_rojas1;
        texto_verde1.text = "" + contador_verdes1;
        texto_azul1.text = "" + contador_azules1;

        texto_rojas2.text = "" + contador_rojas2;
        texto_verde2.text = "" + contador_verdes2;
        texto_azul2.text = "" + contador_azules2;

        texto_rojas3.text = "" + contador_rojas3;
        texto_verde3.text = "" + contador_verdes3;
        texto_azul3.text = "" + contador_azules3;

        texto_rojas4.text = "" + contador_rojas4;
        texto_verde4.text = "" + contador_verdes4;
        texto_azul4.text = "" + contador_azules4;

        texto_intentos.text = "" + contador_intentos;


        if (verificar == true)
        {
            sacar();
            verificar = false;
        }

        if (contador_intentos <= 0 && contador_buenas < 3)
        {
            perdiste.SetActive(true);
            terminar = true;
        }
        if (contador_buenas == 3)
        {
            ganaste.SetActive(true);
            terminar = true;
        }
        if (contador_malas == 3)
        {

        }

        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
                SceneManager.LoadScene(0);
        }
        
    }

    public void sacar_balota()
    {
        if (contador_intentos > 0 && terminar==false)
        {
            /*for (int i = 0; i < 100; i++)
            {
                num_resutado = Random.Range(0, rango_probabilidad);
                print(num_resutado);
            }*/
            num_resutado = Random.Range(0, rango_probabilidad);
            verificar = true;
            contador_intentos--;
            
        }
       
    }
    public void sacar()
    {
        switch (num_resutado)
        {
            case 0:
                resultado.material.color = Color.green;
                contador_buenas++;
                if (contador_intentos==3)
                {
                    contador_verdes1++;
                }

                if (contador_intentos==2)
                {
                    contador_verdes2++;
  
                }
                if (contador_intentos==1)
                {
                    contador_verdes3++;
                    
                }
                if (contador_intentos==0)
                {
                    contador_verdes4++;
                }
                break;

            case 1:
                resultado.material.color = Color.blue;
                contador_malas++;
                if (contador_intentos == 3)
                {
                    contador_azules1++;
                }

                if (contador_intentos == 2)
                {
                    contador_azules2++;

                }
                if (contador_intentos == 1)
                {
                    contador_azules3++;

                }
                if (contador_intentos == 0)
                {
                    contador_azules4++;
                }
                break;

            case 2:
                resultado.material.color = Color.red;
                contador_malas++;
                if (contador_intentos == 3)
                {
                    contador_rojas1++;
                   
                }

                if (contador_intentos == 2)
                {
                    contador_rojas2++;

                }
                if (contador_intentos == 1)
                {
                    contador_rojas3++;

                }
                if (contador_intentos == 0)
                {
                    contador_rojas4++;
                }
                
                break;

            case 3:
                resultado.material.color = Color.green;
                contador_buenas++;
                if (contador_intentos == 3)
                {
                    contador_verdes1++;        
                }

                if (contador_intentos == 2)
                {
                    contador_verdes2++;

                }
                if (contador_intentos == 1)
                {
                    contador_verdes3++;

                }
                if (contador_intentos == 0)
                {
                    contador_verdes4++;
                }
                break;
        }
    }
}
