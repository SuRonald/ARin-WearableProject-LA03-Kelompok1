using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiUI : MonoBehaviour
{
    public static bool firstOpen = true;
    public static string destinationpage;
    public GameObject splashScreen;
    public GameObject homePanel;
    public GameObject hotelPanel;
    public GameObject tutorialPanel;
    public GameObject successPanel;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if (!firstOpen)
        {
            splashScreen.SetActive(false);

            if (destinationpage == "TutorialPanel")
            {
                SlideAnimation(homePanel);
                SlideAnimation(hotelPanel);
            }
            else if (destinationpage == "SuccessPanel")
            {
                successPanel.SetActive(true);
            }
        }
        else
        {
            StartCoroutine(WaitCoroutine(4f, splashScreen, false));
            firstOpen = !firstOpen;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SlideAnimation(GameObject UIPage)
    {
        animator = UIPage.GetComponent<Animator>();
        bool isOpen = animator.GetBool("open");
        animator.SetBool("open", !isOpen);
        Debug.Log(isOpen);
        if (!isOpen)
        {
            Debug.Log("masuk coroutine");
            //StartCoroutine(WaitCoroutine(1f, homePanel, false));
        }
        else
        {
            Debug.Log("masuk setActive");
            //homePanel.SetActive(true);
        }
    }

    public void ToHome()
    {
        successPanel.SetActive(false);
    }

    public void ToARView()
    {
        SceneManager.LoadScene("ViewScene");
    }

    public void ToTutorial()
    {
        destinationpage = "TutorialPanel";
        SceneManager.LoadScene("AppUI");
    }

    public void OnBooked()
    {
        destinationpage = "SuccessPanel";
        SceneManager.LoadScene("AppUI");
    }

    private IEnumerator WaitCoroutine(float time, GameObject selectedPanel, bool activeValue)
    {
        yield return new WaitForSeconds(time);
        Debug.Log("Panel Deactive");
        selectedPanel.SetActive(activeValue);
    }
}
