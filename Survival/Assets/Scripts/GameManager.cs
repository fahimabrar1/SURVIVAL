using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    /*---------------------------------------------------------------------
      --------------------------------------------------------------------
      
        This Script Controls The UI Of the GamePlay. Specially Buttons

      --------------------------------------------------------------------
      --------------------------------------------------------------------*/

    public GameObject shelter, fire, crafting,explore, inventory, hunt;
    public GameObject shelterSystem, fireSystem, craftingSystem , inventorySystem, huntSystem;
    public GameObject PausePanel;
    public Button backToGameplay, pauseButton;
    

    private void Start()
    {
        //setting on all the options.
        shelter.SetActive(true);
        fire.SetActive(true);
        crafting.SetActive(true);
        explore.SetActive(true);
        inventory.SetActive(true);
        hunt.SetActive(true);

        //Settign off all the Systems.
        shelterSystem.SetActive(false);
        fireSystem.SetActive(false);
        craftingSystem.SetActive(false);
        inventorySystem.SetActive(false);
        huntSystem.SetActive(false);

        //initializing buttons.
        pauseButton.gameObject.SetActive(true);
        backToGameplay.gameObject.SetActive(false);
    }

    public void OnShelterClik()
    {
        shelter.SetActive(false);
        fire.SetActive(false);
        crafting.SetActive(false);
        explore .SetActive(false);
        inventory.SetActive(false);
        hunt.SetActive(false);

        shelterSystem.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        backToGameplay.gameObject.SetActive(true);
    }
    
    public void OnFireClik()
    {
        shelter.SetActive(false);
        fire.SetActive(false);
        crafting.SetActive(false);
        explore.SetActive(false);
        inventory.SetActive(false);
        hunt.SetActive(false);

        fireSystem.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        backToGameplay.gameObject.SetActive(true);
    }
    
    public void OnCraftingClik()
    {
        shelter.SetActive(false);
        fire.SetActive(false);
        crafting.SetActive(false);
        explore.SetActive(false);
        inventory.SetActive(false);
        hunt.SetActive(false);

        craftingSystem.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        backToGameplay.gameObject.SetActive(true);
    }
    
    public void OnExploreClik()
    {
        //1 hour will be deducted
    }
    
    public void OnInventoryClik()
    {
        shelter.SetActive(false);
        fire.SetActive(false);
        crafting.SetActive(false);
        explore.SetActive(false);
        inventory.SetActive(false);
        hunt.SetActive(false);

        inventorySystem.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        backToGameplay.gameObject.SetActive(true);
    }
    
    public void OnHuntClik()
    {
        shelter.SetActive(false);
        fire.SetActive(false);
        crafting.SetActive(false);
        explore.SetActive(false);
        inventory.SetActive(false);
        hunt.SetActive(false);

        huntSystem.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        backToGameplay.gameObject.SetActive(true);
    }

    public void onBackClick()
    {
        Start();
    }
    
    public void onPauseClick()
    {
        PausePanel.SetActive(true);
    }

    public void onResume()
    {
        PausePanel.SetActive(false);
    }

    public void onQuit()
    {
        
    }
}
