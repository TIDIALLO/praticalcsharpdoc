var employeeDataFileReaderWriter = new FileReaderWriter<EmployeeData>();
employeeDataFileReaderWriter.Initialize();

employeeDataFileReaderWriter.Write(new EmployeeData
    { DataId = 1, DataDescription = "Some description.", EmployeeName = "Ahmed" });

var ahmed = employeeDataFileReaderWriter.Read(1);