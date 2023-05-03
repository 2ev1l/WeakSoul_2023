using UnityEngine;
using UnityEngine.UI;
using Universal;

namespace WeakSoul.MainMenu
{
    public class StyleItem : MonoBehaviour, IListUpdater
    {
        #region fields & properties
        [SerializeField] private Text txt;
        [SerializeField] private TextOutline outline;
        private int id;
        public GameObject rootObject => gameObject;
        public int listParam => id;
        #endregion fields & properties

        #region methods
        private void Start()
        {
            outline.UpdateFontStyle = false;
        }
        public void OnListUpdate(int param)
        {
            id = param;
            txt.text = StyleItemList.StylesText[id];
            txt.fontStyle = (FontStyle)id;
        }
        #endregion methods
    }
}