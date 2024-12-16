using CrimeReportingSystemAPP.Entity;
using CrimeReportingSystemAPP.dao;
using NUnit.Framework;

namespace CrimeReportingSystem.Tests
{
    public class Tests
    {
        ICrimeAnalysisService service = new CrimeAnalysisService();

        [Test]
        public void TestToAddIncident()
        {
            Incidents incident = new Incidents()
            {
                IncidentType = "Homicide",
                IncidentDate = DateTime.Now,
                Location = "Test location",
                Description = "Test description",
                Status = "Open",
                AgencyId = 1
            };
            int addIncidentStatus = service.AddIncidents(incident);
            Assert.That(addIncidentStatus, Is.GreaterThan(0), "Incident ID should be greater than 0");
        }

        [Test]
        public void TestToUpdateIncident()
        {
            int incidentId = 2;
            string status = "Closed";
            int updateIncidentStatus = service.UpdateIncidentStatus(incidentId, status);
            Assert.That(updateIncidentStatus, Is.EqualTo(1));
        }
    }
}
