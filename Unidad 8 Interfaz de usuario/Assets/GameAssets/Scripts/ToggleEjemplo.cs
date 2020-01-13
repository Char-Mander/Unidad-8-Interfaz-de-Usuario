using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public enum characterType { Warrior,Mage,Archer}

public class ToggleEjemplo : MonoBehaviour
{
    public Toggle tggMusicOnOff;

    public ToggleGroup tggGrCharacterSelect;

    public List<Sprite> characterImages = new List<Sprite>();
    public Image characterFace;


    private void Start()
    {
        SelectCharacter();
    }

    public void CambioDeToggle() {

        FindObjectOfType<PauseController>().MusicOnOff(tggMusicOnOff.isOn);

    }

    public void SelectCharacter() {
        Toggle activeTgg = tggGrCharacterSelect.ActiveToggles().First();
        characterFace.sprite = characterImages[(int)activeTgg.GetComponent<CharacterTypeScr>().tipo];

    }

}
