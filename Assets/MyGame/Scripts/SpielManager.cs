using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpielManager : MonoBehaviour
{
    [SerializeField] float timeValue = 60;
    [SerializeField] TextMeshProUGUI timer;
    [SerializeField] GameObject zeitAus;
    [SerializeField] GameObject zeitAusButton;

    private void Start()
    {
        zeitAus.SetActive(false);
        zeitAusButton.SetActive(false);
    }
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue = timeValue - Time.deltaTime;
        }
        else
        {
            zeitAus.SetActive(true);
            zeitAusButton.SetActive(true);
        }
        var ts = TimeSpan.FromSeconds(timeValue);
        timer.text = "Timer: " + string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
    }
    public void NochmalSpielenButton()
    {
        SceneManager.LoadScene(0);
    }
}
