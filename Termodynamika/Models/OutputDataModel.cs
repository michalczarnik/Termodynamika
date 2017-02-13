using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termodynamika.Models
{
    class OutputDataModel
    {
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
                    throw new FieldAccessException("The field CO2 cannot be empty!");
                }
            }
            set
            {
                this._CO2 = value;
            }
        }

        private double _H2O = double.NegativeInfinity;

        public double H2O
        {
            get
            {
                if (_H2O != double.NegativeInfinity)
                {
                    return _H2O;
                }
                else
                {
                    throw new FieldAccessException("The field H2O cannot be empty!");
                }
            }
            set
            {
                this._H2O = value;
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
                    throw new FieldAccessException("The field N2 cannot be empty!");
                }
            }
            set
            {
                this._N2 = value;
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
                    throw new FieldAccessException("The field O2 cannot be empty!");
                }
            }
            set
            {
                this._O2 = value;
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
                    throw new FieldAccessException("The field Vg cannot be empty!");
                }
            }
            set
            {
                this._Vg = value;
            }
        }

        private double _Vc = double.NegativeInfinity;

        public double Vc
        {
            get
            {
                if (_Vc != double.NegativeInfinity)
                {
                    return _Vc;
                }
                else
                {
                    throw new FieldAccessException("The field Vc cannot be empty!");
                }
            }
            set
            {
                this._Vc = value;
            }
        }

        private double _Vs = double.NegativeInfinity;

        public double Vs
        {
            get
            {
                if (_Vs != double.NegativeInfinity)
                {
                    return _Vs;
                }
                else
                {
                    throw new FieldAccessException("The field Vs cannot be empty!");
                }
            }
            set
            {
                this._Vs = value;
            }
        }

        private double _Vs2 = double.NegativeInfinity;

        public double Vs2
        {
            get
            {
                if (_Vs2 != double.NegativeInfinity)
                {
                    return _Vs2;
                }
                else
                {
                    throw new FieldAccessException("The field Vs2 cannot be empty!");
                }
            }
            set
            {
                this._Vs2 = value;
            }
        }

        private double _tw = double.NegativeInfinity;

        public double tw
        {
            get
            {
                if (_tw != double.NegativeInfinity)
                {
                    return _tw;
                }
                else
                {
                    throw new FieldAccessException("The field tw cannot be empty!");
                }
            }
            set
            {
                this._tw = value;
            }
        }

        private double _ta = double.NegativeInfinity;

        public double ta
        {
            get
            {
                if (_ta != double.NegativeInfinity)
                {
                    return _ta;
                }
                else
                {
                    throw new FieldAccessException("The field ta cannot be empty!");
                }
            }
            set
            {
                this._ta = value;
            }
        }

        private double _ts = double.NegativeInfinity;

        public double ts
        {
            get
            {
                if (_ts != double.NegativeInfinity)
                {
                    return _ts;
                }
                else
                {
                    throw new FieldAccessException("The field ts cannot be empty!");
                }
            }
            set
            {
                this._ts = value;
            }
        }

        private double _Qq = double.NegativeInfinity;

        public double Qq
        {
            get
            {
                if (_Qq != double.NegativeInfinity)
                {
                    return _Qq;
                }
                else
                {
                    throw new FieldAccessException("The field Qq cannot be empty!");
                }
            }
            set
            {
                this._Qq = value;
            }
        }

        private double _Qp = double.NegativeInfinity;

        public double Qp
        {
            get
            {
                if (_Qp != double.NegativeInfinity)
                {
                    return _Qp;
                }
                else
                {
                    throw new FieldAccessException("The field Qp cannot be empty!");
                }
            }
            set
            {
                this._Qp = value;
            }
        }

        private double _Qw = double.NegativeInfinity;

        public double Qw
        {
            get
            {
                if (_Qw != double.NegativeInfinity)
                {
                    return _Qw;
                }
                else
                {
                    throw new FieldAccessException("The field Qw cannot be empty!");
                }
            }
            set
            {
                this._Qw = value;
            }
        }

        private double _Qs = double.NegativeInfinity;

        public double Qs
        {
            get
            {
                if (_Qs != double.NegativeInfinity)
                {
                    return _Qs;
                }
                else
                {
                    throw new FieldAccessException("The field Qs cannot be empty!");
                }
            }
            set
            {
                this._Qs = value;
            }
        }

        private double _Qstr = double.NegativeInfinity;

        public double Qstr
        {
            get
            {
                if (_Qstr != double.NegativeInfinity)
                {
                    return _Qstr;
                }
                else
                {
                    throw new FieldAccessException("The field Qstr cannot be empty!");
                }
            }
            set
            {
                this._Qstr = value;
            }
        }

        private double _eta = double.NegativeInfinity;

        public double eta
        {
            get
            {
                if (_eta != double.NegativeInfinity)
                {
                    return _eta;
                }
                else
                {
                    throw new FieldAccessException("The field eta cannot be empty!");
                }
            }
            set
            {
                this._eta = value;
            }
        }
    }
}
