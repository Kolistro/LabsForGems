namespace ModelingOperationOfSpeedControlPoint.Writer
{
    public interface IWriter
    {
        public void Write(string str);
        public void WriteAboutViolation(string violation);
    }
}
