using System;
using System.Collections.Generic;

namespace ODE {

    class RungeKutta {

        // вспомогательная функция для метода Рунге-Кутта
        static double func(double dv, double x, double lambda, double n) {
            return -1 * (lambda * dv * Math.Sin(2 * n * x) + Math.Cos(n * x));
        }

        // метод Рунге-Кутта 4-го порядка
        public static void RungKUtt(double begin, double end, double h, double lambda, 
            double x0dash, double n, List<double> res, List<double> res_v) {

            double _dx = begin, _dv = x0dash;
            for (double i = begin; i < end; i += h) {
                res.Add(_dx);
                res_v.Add(_dv);

                double dx1 = h * _dv;
                double dv1 = h * func(_dv, _dx, lambda, n);
                double dx2 = h * (_dv + dv1 / 2);
                double dv2 = h * func(_dv + dv1 / 2, _dx + dx1 / 2, lambda, n);
                double dx3 = h * (_dv + dv2 / 2);
                double dv3 = h * func(_dv + dv2 / 2, _dx + dx2 / 2, lambda, n);
                double dx4 = h * (_dv + dv3);
                double dv4 = h * func(_dv + dv3, _dx + dx3, lambda, n);
                double dx = (dx1 + 2 * dx2 + 2 * dx3 + dx4) / 6;
                double dv = (dv1 + 2 * dv2 + 2 * dv3 + dv4) / 6;

                _dx += dx;
                _dv += dv;
            }
            res.Add(_dv);
        }
    }
}
