using System;
namespace dlu_persistence_api.models
{
    public class By
    {

        private int postNr;
private string postBy;
private int husstane;
 private double maxDækningsGrad;
        public By()
        {
        }

        public int PostNr { get => postNr; set => postNr = value; }
        public string PostBy { get => postBy; set => postBy = value; }
        public int Husstane { get => husstane; set => husstane = value; }
        public double MaxDækningsGrad { get => maxDækningsGrad; set => maxDækningsGrad = value; }
    }
}
