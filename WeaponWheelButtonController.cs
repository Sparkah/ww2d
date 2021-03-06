using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class WeaponWheelButtonController : MonoBehaviour
{
    [SerializeField] private int _iD;
    private Animator _animator;
    [SerializeField] private string _itemName;
    [SerializeField] private TextMeshProUGUI _itemText;
    [SerializeField] private Image _selectedItem;
    private bool _selected = false;
    [SerializeField] private Sprite _icon;
    private WeaponWheelController _weaponWheelController;

    private void Start()
    {
        //Вот тут вопрос, [RequireComponent(typeof(WeaponWheelController))] не будет работать. можно добавить проверку на null?
        _weaponWheelController = GetComponentInParent<WeaponWheelController>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_selected)
        {
            _selectedItem.sprite = _icon;
            _itemText.text = _itemName;
        }
    }

    public void WeaponSelected(bool selected)
    {
        _selected = selected;
        _weaponWheelController.WeaponID = _iD;
    }

    public void Hover(bool _selected)
    {
        _animator.SetBool(WeaponWheelController.AnimationStates.Hovered.ToString(), _selected);
        if(!_selected)
            _itemText.text = "";
        if(_selected)
            _itemText.text = _itemName;
    }
}