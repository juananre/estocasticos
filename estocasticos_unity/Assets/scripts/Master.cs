using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Master : MonoBehaviour
{
    [SerializeField] GameObject balota;
    [SerializeField] Renderer resultado;
    [SerializeField] int num_resutado = 0;

    [SerializeField] int contador_intentos = 5;
    [SerializeField] int contador_buenas;
    [SerializeField] int contador_malas;

    [SerializeField] int contador_rojas;
    [SerializeField] int contador_verdes;
    [SerializeField] int contador_azules;

    [SerializeField] int rango_probabilidad = 3;

    [SerializeField] TextMeshProUGUI texto_rojas;
    [SerializeField] TextMeshProUGUI texto_azul;
    [SerializeField] TextMeshProUGUI texto_verde;
    [SerializeField] TextMeshProUGUI texto_intentos;


    bool verificar = false;

    // Start is called before the first frame update
    void Start()
    {
        resultado = balota.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        texto_rojas.text = "" + contador_rojas;
        texto_verde.text = "" + contador_verdes;
        texto_azul.text = "" + contador_azules;
        texto_intentos.text = "" + contador_intentos;


        if (verificar == true)
        {
            sacar();
            verificar = false;
        }

        if (contador_intentos <= 0)
        {

        }
        if (contador_buenas == 3)
        {

        }
        if (contador_malas == 3)
        {

        }
    }

    public void sacar_balota()
    {
        if (contador_intentos > 0)
        {
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
                contador_verdes++;
                break;

            case 1:
                resultado.material.color = Color.blue;
                contador_malas++;
                contador_azules++;
                break;

            case 2:
                resultado.material.color = Color.red;
                contador_malas++;
                contador_rojas++;
                break;
        }
    }
}
