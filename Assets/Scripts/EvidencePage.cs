using UnityEngine;
using System.Collections;

public class EvidencePage : MonoBehaviour {

    public GameObject LibrePage;
    public GameObject PiePage;
    public GameObject BarPage;

    private ButtonClicks buttonClickScript;

    public enum evidenceOptions
    {
        Libre,
        Pie,
        Bar,
        None
    };
    private evidenceOptions evidenceActive;

    void Start()
    {
        buttonClickScript = GameObject.Find("Canvas").GetComponent<ButtonClicks>();

        evidenceActive = evidenceOptions.None;
        LibrePage.SetActive(false);
        PiePage.SetActive(false);
        BarPage.SetActive(false);
    }


    public void ChangeEvidenceButton(int intButton)
    {
        evidenceOptions but = (evidenceOptions)intButton;
        
        if(evidenceActive != evidenceOptions.None)
        {
            if (evidenceActive == but)
            {
                GetGameObjectButton(but).SetActive(!(GetGameObjectButton(evidenceActive).activeInHierarchy));
            }
            else
            {
                GetGameObjectButton(evidenceActive).SetActive(false);
                GetGameObjectButton(but).SetActive(true);
            }
        } else
        {
            GetGameObjectButton(but).SetActive(true);
        }


        evidenceActive = but;
    }

    public GameObject GetGameObjectButton(evidenceOptions but)
    {
        switch (but)
        {
            case evidenceOptions.Libre:
                return LibrePage;
            case evidenceOptions.Pie:
                return PiePage;
            case evidenceOptions.Bar:
                return BarPage;
        }
        return null;
    }
}
