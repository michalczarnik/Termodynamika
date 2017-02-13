using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termodynamika.Models
{
    class InputDataModel
    {
        private double _CO = double.NegativeInfinity;

        public double CO
        {
            get
            {
                if (_CO != double.NegativeInfinity)
                {
                    return _CO;
                }
                else
                {
                    throw new FieldAccessException("The field _CO cannot be empty!");
                }
            }
            set
            {
                this._CO = value;
            }
        }

        private double _CO2 = double.NegativeInfinity;

        public double CO2
        {
            get
            {
                if (_CO2 != double.NegativeInfinity)
                {
                    return _CO2;
                }
                else
                {
                    throw new FieldAccessException("The field _CO2 cannot be empty!");
                }
            }
            set
            {
                this._CO2 = value;
            }
        }

        private double _CH4 = double.NegativeInfinity;

        public double CH4
        {
            get
            {
                if (_CH4 != double.NegativeInfinity)
                {
                    return _CH4;
                }
                else
                {
                    throw new FieldAccessException("The field _CH4 cannot be empty!");
                }
            }
            set
            {
                this._CH4 = value;
            }
        }

        private double _O2 = double.NegativeInfinity;

        public double O2
        {
            get
            {
                if (_O2 != double.NegativeInfinity)
                {
                    return _O2;
                }
                else
                {
                    throw new FieldAccessException("The field _O2 cannot be empty!");
                }
            }
            set
            {
                this._O2 = value;
            }
        }

        private double _N2 = double.NegativeInfinity;

        public double N2
        {
            get
            {
                if (_N2 != double.NegativeInfinity)
                {
                    return _N2;
                }
                else
                {
                    throw new FieldAccessException("The field _N2 cannot be empty!");
                }
            }
            set
            {
                this._N2 = value;
            }
        }

        private double _H2 = double.NegativeInfinity;

        public double H2
        {
            get
            {
                if (_H2 != double.NegativeInfinity)
                {
                    return _H2;
                }
                else
                {
                    throw new FieldAccessException("The field _H2 cannot be empty!");
                }
            }
            set
            {
                this._H2 = value;
            }
        }

        private double _Lambda = double.NegativeInfinity;

        public double Lambda
        {
            get
            {
                if (_Lambda != double.NegativeInfinity)
                {
                    return _Lambda;
                }
                else
                {
                    throw new FieldAccessException("The field _Lambda cannot be empty!");
                }
            }
            set
            {
                this._Lambda = value;
            }
        }

        private double _Vg = double.NegativeInfinity;

        public double Vg
        {
            get
            {
                if (_Vg != double.NegativeInfinity)
                {
                    return _Vg;
                }
                else
                {
                    throw new FieldAccessException("The field _Vg cannot be empty!");
                }
            }
            set
            {
                this._Vg = value;
            }
        }

        private double _tg = double.NegativeInfinity;

        public double tg
        {
            get
            {
                if (_tg != double.NegativeInfinity)
                {
                    return _tg;
                }
                else
                {
                    throw new FieldAccessException("The field _tg cannot be empty!");
                }
            }
            set
            {
                this._tg = value;
            }
        }

        private double _tp = double.NegativeInfinity;

        public double tp
        {
            get
            {
                if (_tp != double.NegativeInfinity)
                {
                    return _tp;
                }
                else
                {
                    throw new FieldAccessException("The field _tp cannot be empty!");
                }
            }
            set
            {
                this._tp = value;
            }
        }

        private double _twin = double.NegativeInfinity;

        public double twin
        {
            get
            {
                if (_twin != double.NegativeInfinity)
                {
                    return _twin;
                }
                else
                {
                    throw new FieldAccessException("The field _twin cannot be empty!");
                }
            }
            set
            {
                this._twin = value;
            }
        }

        private double _mw = double.NegativeInfinity;

        public double mw
        {
            get
            {
                if (_mw != double.NegativeInfinity)
                {
                    return _mw;
                }
                else
                {
                    throw new FieldAccessException("The field _mw cannot be empty!");
                }
            }
            set
            {
                this._mw = value;
            }
        }

        private double _A = double.NegativeInfinity;

        public double A
        {
            get
            {
                if (_A != double.NegativeInfinity)
                {
                    return _A;
                }
                else
                {
                    throw new FieldAccessException("The field _A cannot be empty!");
                }
            }
            set
            {
                this._A = value;
            }
        }

        private double _alfa = double.NegativeInfinity;

        public double alfa
        {
            get
            {
                if (_alfa != double.NegativeInfinity)
                {
                    return _alfa;
                }
                else
                {
                    throw new FieldAccessException("The field _alfa cannot be empty!");
                }
            }
            set
            {
                this._alfa = value;
            }
        }

        private double _beta = double.NegativeInfinity;

        public double beta
        {
            get
            {
                if (_beta != double.NegativeInfinity)
                {
                    return _beta;
                }
                else
                {
                    throw new FieldAccessException("The field _beta cannot be empty!");
                }
            }
            set
            {
                this._beta = value;
            }
        }
    }
}
