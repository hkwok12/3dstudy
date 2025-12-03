using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Inven_Item : UI_Base
{
    enum GameObjects
    {
        ItemIcon,
        ItemNameText,
    }

    string _name;

    void Start()
    {
        Init();
    }

    public override void Init()
    {   
        //아이콘이랑 바인드
        Bind<GameObject>(typeof(GameObjects));
        Get<GameObject>((int)GameObjects.ItemNameText).GetComponent<Text>().text = _name;

        //GameObject icon = Get<GameObject>((int)GameObjects.ItemIcon);
        //BindEvent(icon, (PointerEventData data) => { Debug.Log($"아이템 클릭 ({_name})"); });
        Get<GameObject>((int)GameObjects.ItemIcon).BindEvent((PointerEventData data) => { Debug.Log($"아이템 클릭 ({_name})"); });
    }

    public void SetInfo(string name)
    {
        _name = name;
    }
}
