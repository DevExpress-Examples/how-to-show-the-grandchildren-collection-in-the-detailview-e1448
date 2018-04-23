using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace WinSample.Module {
    [DefaultClassOptions]
    public class Detail : BaseObject {
        public Detail(Session session) : base(session) { }
        private string _DetailName;
        public string DetailName {
            get { return _DetailName; }
            set { SetPropertyValue("DetailName", ref _DetailName, value); }
        }
        private Master _Master;
        [Association("Master-Details")]
        public Master Master {
            get { return _Master; }
            set { SetPropertyValue("Master", ref _Master, value); }
        }
        [Association("Details-SubDetails")]
        public XPCollection<SubDetail> SubDetails {
            get {
                return GetCollection<SubDetail>("SubDetails");
            }
        }
    }
}
