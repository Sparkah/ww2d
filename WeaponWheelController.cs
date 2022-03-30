using UnityEngine;
using UnityEngine.UI;

public class WeaponWheelController : MonoBehaviour
{
    [SerializeField] private Animator _animatorWeaponWheel;
    private bool _weaponWheelSelected = false;
    [SerializeField] private Image _selectedItem;
    [SerializeField] private Sprite _noImage;

    private int _weaponID;
    public int WeaponID
    {
        get => _weaponID;
        set { _weaponID = value; }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _weaponWheelSelected = !_weaponWheelSelected;
        }

        if (_weaponWheelSelected)
        {
            _animatorWeaponWheel.SetBool(AnimationStates.OpenWeaponWheel.ToString(), true);
        }
        if (!_weaponWheelSelected)
        {
            _animatorWeaponWheel.SetBool(AnimationStates.OpenWeaponWheel.ToString(), false);
        }

        switch (WeaponID)
        {
            case 0:
                _selectedItem.sprite = _noImage;
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
