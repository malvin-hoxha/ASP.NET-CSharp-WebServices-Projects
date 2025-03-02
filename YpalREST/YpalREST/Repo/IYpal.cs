using YpalREST.Models;

namespace YpalREST.Repo
{
    public interface IYpal
    {
        public IEnumerable<Ypal> GetYpals();
        public Ypal GetYpal(Guid id);
        public void CreateYpal(Ypal ypal);
    }
}
