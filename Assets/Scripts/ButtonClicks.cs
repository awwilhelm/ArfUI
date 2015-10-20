using UnityEngine;
using System.Collections;

public class ButtonClicks : MonoBehaviour {

    public GameObject panelButton1;
    public GameObject panelButton2;
    public GameObject panelButton3;
    public GameObject panelButton4;

    public GameObject MainPage;
    public GameObject EvidencePage;
    public GameObject InfoPage;

    private GameObject currentPage;
    private GameObject previousPage;

	// Use this for initialization
	void Start ()
    {
        panelButton1.SetActive(true);
        SetAllPagesToFalse();
        MainPage.SetActive(true);
        currentPage = MainPage;
        previousPage = MainPage;
    }

    public void SetAllPagesToFalse()
    {
        MainPage.SetActive(false);
        EvidencePage.SetActive(false);
        InfoPage.SetActive(false);
    }

    


    //Main Menu
    public void HelpMainMenu()
    {

    }

    public void EvidenceMainMenu()
    {
        MainPage.SetActive(false);
        EvidencePage.SetActive(true);
        SetCurrentPage(EvidencePage);
        SetPreviousPage(MainPage);
    }

    public void InfoMainMenu()
    {
        MainPage.SetActive(false);
        InfoPage.SetActive(true);
        SetCurrentPage(EvidencePage);
        SetPreviousPage(MainPage);
    }

    public void CallMainMenu()
    {

    }

    public void ArgumentationMainMenu()
    {

    }



    public void GoToPreviousPage()
    {
        GameObject temp = GetCurrentPage();
        SetCurrentPage(GetPreviousPage());
        SetPreviousPage(temp);
        SetAllPagesToFalse();
        GetCurrentPage().SetActive(true);
    }

    public GameObject GetCurrentPage()
    {
        return currentPage;
    }

    public void SetCurrentPage(GameObject newPage)
    {
        currentPage = newPage;
    }

    public GameObject GetPreviousPage()
    {
        return previousPage;
    }

    public void SetPreviousPage(GameObject newPage)
    {
        previousPage = newPage;
    }
    
}
