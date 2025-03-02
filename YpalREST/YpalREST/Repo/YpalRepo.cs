using YpalREST.Models;

namespace YpalREST.Repo
{
    public class YpalRepo : IYpal
    {
        private List<Ypal> _Ypals;

        public YpalRepo()
        {
            // καταχώριση ενός πρώτου βιβλίου
            _Ypals = new() { new Ypal
             { YpalID=Guid.NewGuid(), Name="Marcus Aurelius", Email="marcusaurelius@gmail.com"}
             };
        }

        public IEnumerable<Ypal> GetYpals()
        {
            return _Ypals;
        }

        public Ypal GetYpal(Guid id)
        {
            var ypal = _Ypals.Where(x => x.YpalID == id).SingleOrDefault();
            return ypal;
        }


        public void CreateYpal(Ypal ypal)
        {
            _Ypals.Add(ypal);
        }
    }
}
