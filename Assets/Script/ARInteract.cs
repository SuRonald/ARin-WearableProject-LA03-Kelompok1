using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class ARInteract : MonoBehaviour
{
    public GameObject room_panel;
    public TextMeshProUGUI room_name_text;
    public TextMeshProUGUI room_bed_qnty;
    public TextMeshProUGUI room_people_cap;
    public TextMeshProUGUI room_food_service;
    public GameObject detail_button;
    public GameObject close_button;
    public VirtualButtonBehaviour vbtn_double;
    public VirtualButtonBehaviour vbtn_twin;
    public VirtualButtonBehaviour vbtn_triple;
    public VirtualButtonBehaviour vbtn_plus;
    public VirtualButtonBehaviour vbtn_presidential;
    public VirtualButtonBehaviour vbtn_suite;
    public GameObject room_double;
    public GameObject room_twin;
    public GameObject room_triple;
    public GameObject room_plus;
    public GameObject room_presidential;
    public GameObject room_suite;

    // Start is called before the first frame update
    void Start()
    {
        vbtn_double.RegisterOnButtonPressed(OnButtonPressedDouble);
        vbtn_twin.RegisterOnButtonPressed(OnButtonPressedTwin);
        vbtn_triple.RegisterOnButtonPressed(OnButtonPressedTriple);
        vbtn_plus.RegisterOnButtonPressed(OnButtonPressedPlus);
        vbtn_presidential.RegisterOnButtonPressed(OnButtonPressedPresidential);
        vbtn_suite.RegisterOnButtonPressed(OnButtonPressedSuite);
        Debug.Log("Masuk");
    }

    public void allOff()
    {
        room_double.SetActive(false);
        room_twin.SetActive(false);
        room_triple.SetActive(false);
        room_plus.SetActive(false);
        room_presidential.SetActive(false);
        room_suite.SetActive(false);
        Debug.Log("All Clear");
    }

    public void setInfo(GameObject roomModel, string roomName, string bedQnty, string peopleCap, string foodService)
    {
        allOff();
        roomModel.SetActive(true);
        room_panel.SetActive(true);
        room_name_text.text = roomName;
        room_bed_qnty.text = bedQnty;
        room_people_cap.text = peopleCap;
        room_food_service.text = foodService;
    }

    public void OnButtonPressedDouble(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        setInfo(room_double, "Double Bed", "1 Double Bed", "2 Peoples", "2 Dinner");
    }

    public void OnButtonPressedTwin(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        setInfo(room_twin, "Twin Bed", "2 Single Beds", "2 Peoples", "2 Dinner");
    }

    public void OnButtonPressedTriple(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        setInfo(room_triple, "Triplet Bed", "3 Single Beds", "3 Peoples", "3 Dinner");
    }

    public void OnButtonPressedPlus(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        setInfo(room_plus, "Studio Plus", "1 Double Bed", "2 Peoples", "2 Dinner");
    }

    public void OnButtonPressedPresidential(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        setInfo(room_presidential, "Presidential Suite", "1 Double Bed", "2 Peoples", "2 Dinner");
    }

    public void OnButtonPressedSuite(VirtualButtonBehaviour vb)
    {
        Debug.Log(vb.VirtualButtonName);
        setInfo(room_suite, "Big Suite", "1 Double Bed", "2 Peoples", "2 Dinner");
    }

    public void info_slide_animation()
    {
        Animator animator = room_panel.GetComponent<Animator>();
        bool isOpen = animator.GetBool("open");
        animator.SetBool("open", !isOpen);
        Debug.Log(isOpen);
        if (isOpen)
        {
            detail_button.SetActive(true);
            close_button.SetActive(false);
        }
        else
        {
            detail_button.SetActive(false);
            close_button.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
