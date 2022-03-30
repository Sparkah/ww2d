using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class WeaponWheelButtonController : MonoBehaviour
{
    public int ID;
    private Animator _animator;
    public string ItemName;
    public TextMeshProUGUI ItemText;
    public Image SelectedItem;
    private bool _selected = false;
    public Sprite Icon;
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
            SelectedItem.sprite = Icon;
            ItemText.text = ItemName;
        }
    }

    public void WeaponSelected(bool selected)
    {
        _selected = selected;
        _weaponWheelController.WeaponID = ID;
    }

    public void Hover(bool _selected)
    {
        _animator.SetBool(WeaponWheelController.AnimationStates.Hovered.ToString(), _selected);
        if(!_selected)
            ItemText.text = "";
        if(_selected)
            ItemText.text = ItemName;
    }
}