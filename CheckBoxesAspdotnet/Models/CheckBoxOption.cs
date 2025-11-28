using Microsoft.AspNetCore.Identity;

namespace CheckBoxesAspdotnet.Models
{
    public class CheckBoxOption
    {
        public bool IsChecked { get; set; }
        public string Text { get; set; }

        public string Value { get; set; }
    }
}
