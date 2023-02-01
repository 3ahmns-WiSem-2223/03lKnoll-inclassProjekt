using TMPro;
using UnityEngine;

public class Abschiessen : MonoBehaviour
{
    bool akteviert;
    [SerializeField] GameObject zielScheibe;
    [SerializeField] GameObject zielScheibe1;
    [SerializeField] GameObject zielScheibe2;
    [SerializeField] TextMeshProUGUI punkteAnzahlText;
    int punkteAnzahl;
    //Vector2 randomPosition;
    float xPosition;
    float yPosition;
    int warten;

    public void MausDruecken()
    {
        //zielScheibe.SetActive(false);
        xPosition = Random.Range(50, 850);
        yPosition = Random.Range(50, 310);
        int warten = Random.Range(10, 16);
        zielScheibe.transform.position = new Vector2(xPosition, yPosition);
        //WaitRandomly();
        //akteviert = false;
        punkteAnzahl++;
        punkteAnzahlText.text = "Counter: " + punkteAnzahl.ToString();
    }
    /*IEnumerator WaitRandomly()
    {
        Debug.Log(warten);
        yield return new WaitForSeconds(warten);
        
        Counter();
    }
    void Counter()
    {

    }*/
    
    public void MausDruecken1()
    {
        //zielScheibe.SetActive(false);
        xPosition = Random.Range(50, 850);
        yPosition = Random.Range(50, 310);
        zielScheibe1.transform.position = new Vector2(xPosition, yPosition);

        //akteviert = false;
        punkteAnzahl++;
        punkteAnzahlText.text = "Counter: " + punkteAnzahl.ToString();
    }
    public void MausDruecken2()
    {
        //zielScheibe.SetActive(false);
        xPosition = Random.Range(50, 850);
        yPosition = Random.Range(50, 310);
        zielScheibe2.transform.position = new Vector2(xPosition, yPosition);

        //akteviert = false;
        punkteAnzahl++;
        punkteAnzahlText.text = "Counter: " + punkteAnzahl.ToString();
    }
}
