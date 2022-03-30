using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelController : MonoBehaviour
{
    public Animator AnimatorWeaponWheel;
    private bool weaponWheelSelected = false;
    public Image selectedItem;
    public Sprite noImage;
    public int WeaponID;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weaponWheelSelected = !weaponWheelSelected;
        }

        if (weaponWheelSelected)
        {
            AnimatorWeaponWheel.SetBool(AnimationStates.OpenWeaponWheel.ToString(), true);
        }
        if (!weaponWheelSelected)
        {
            AnimatorWeaponWheel.SetBool(AnimationStates.OpenWeaponWheel.ToString(), false);
        }

        switch (WeaponID)
        {
            case 0:
                selectedItem.sprite = noImage;
                break;
            case 1:
                //Debug.Log("Weapon1");
                break;
            case 2:
                //Debug.Log("Weapon2");
                break;
            case 3:
                //Debug.Log("Weapon3");
                break;
            case 4:
                //Debug.Log("Weapon4");
                break;
        }
    }

    public enum AnimationStates
    {
        Hovered,
        OpenWeaponWheel
    }
}
