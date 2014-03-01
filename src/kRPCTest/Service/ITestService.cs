namespace KRPCTest.Service
{
    public interface ITestService
    {
        void ProcedureNoArgsNoReturn ();

        void ProcedureSingleArgNoReturn (KRPC.Schema.KRPC.Response data);

        void ProcedureThreeArgsNoReturn (KRPC.Schema.KRPC.Response x,
                                         KRPC.Schema.KRPC.Request y, KRPC.Schema.KRPC.Response z);

        KRPC.Schema.KRPC.Response ProcedureNoArgsReturns ();

        KRPC.Schema.KRPC.Response ProcedureSingleArgReturns (KRPC.Schema.KRPC.Response data);

        int ProcedureWithValueTypes (float x, string y, byte[] z);

        string PropertyWithGetAndSet { get; set; }

        string PropertyWithGet { get; }

        string PropertyWithSet { set; }

        TestService.TestClass CreateTestObject (string value);

        void DeleteTestObject (TestService.TestClass obj);
    }
}