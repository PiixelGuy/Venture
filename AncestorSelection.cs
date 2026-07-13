    using System.Collections;
    using UnityEngine;
    using TMPro;

    public class AncestorSelectionManager : MonoBehaviour
    {
        [Header("UI")]
        public GameObject mythologySelectionUI;
        public GameObject statSheetUI;

        public TMP_Text announcementText;

        [Header("Stat Sheet")]
        public AncestorStatSheetUI statSheet;

        [Header("Platform")]
        public PlatformFall platformFall;

        private AncestorData chosenAncestor;

        public void ChooseGreek()
        {
            RollAncestor(Mythology.Greek);
        }

        public void ChooseRoman()
        {
            RollAncestor(Mythology.Roman);
        }

        void RollAncestor(Mythology mythology)
        {
            mythologySelectionUI.SetActive(false);

            chosenAncestor = AncestorDatabase.Instance.RollAncestor(mythology);

            if (chosenAncestor == null)
                return;

            PlayerAncestry.Instance.selectedAncestor = chosenAncestor;
            PlayerAncestry.Instance.rolledAttributes.Clear();

            foreach (AttributeType attribute in chosenAncestor.attributes)
            {
                AttributeData data =
                    AttributeDatabase.Instance.GetAttribute(attribute);

                AttributeRoll roll = new AttributeRoll
                {
                    attribute = attribute,

                    buff1 = data.buff1,
                    buff1Value = Random.Range(data.buff1Min, data.buff1Max),

                    buff2 = data.buff2,
                    buff2Value = Random.Range(data.buff2Min, data.buff2Max),

                    buff3 = data.buff3,
                    buff3Value = Random.Range(data.buff3Min, data.buff3Max)
                };

                PlayerAncestry.Instance.rolledAttributes.Add(roll);
            }

            StartCoroutine(ShowResult());
        }

        IEnumerator ShowResult()
        {
            announcementText.gameObject.SetActive(true);

            announcementText.text =
                $"YOUR ANCESTOR IS\n{chosenAncestor.ancestorName.ToUpper()}";

            yield return new WaitForSeconds(3f);

            announcementText.gameObject.SetActive(false);

            statSheetUI.SetActive(true);

            statSheet.Refresh();
        }

        public void ContinueGame()
        {
            statSheetUI.SetActive(false);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            platformFall.StartFall();
        }
    }