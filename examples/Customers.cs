using System.Collections.ObjectModel;

namespace examples
{
    public class Customers : ObservableCollection<Customer>
    {
        public Customers()
        {
            Add(new Customer("赵", "老大","北京市"));
            Add(new Customer("钱", "老二","上海市"));
            Add(new Customer("孙", "老三","江苏省"));
            Add(new Customer("李", "老四","广东省"));
        }
    }
}
