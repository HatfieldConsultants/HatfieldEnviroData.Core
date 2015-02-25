﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hatfield.EnviroData.Core
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class ODM2Entities : DbContext, IDbContext
    {
        public ODM2Entities()
            : base("name=ODM2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActionAnnotation> ActionAnnotations { get; set; }
        public virtual DbSet<ActionBy> ActionBies { get; set; }
        public virtual DbSet<ActionDirective> ActionDirectives { get; set; }
        public virtual DbSet<ActionExtensionPropertyValue> ActionExtensionPropertyValues { get; set; }
        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<Affiliation> Affiliations { get; set; }
        public virtual DbSet<Annotation> Annotations { get; set; }
        public virtual DbSet<AuthorList> AuthorLists { get; set; }
        public virtual DbSet<CalibrationAction> CalibrationActions { get; set; }
        public virtual DbSet<CalibrationReferenceEquipment> CalibrationReferenceEquipments { get; set; }
        public virtual DbSet<CalibrationStandard> CalibrationStandards { get; set; }
        public virtual DbSet<CategoricalResult> CategoricalResults { get; set; }
        public virtual DbSet<CategoricalResultValueAnnotation> CategoricalResultValueAnnotations { get; set; }
        public virtual DbSet<CategoricalResultValue> CategoricalResultValues { get; set; }
        public virtual DbSet<CitationExtensionPropertyValue> CitationExtensionPropertyValues { get; set; }
        public virtual DbSet<CitationExternalIdentifier> CitationExternalIdentifiers { get; set; }
        public virtual DbSet<Citation> Citations { get; set; }
        public virtual DbSet<CVTerm> CVTerms { get; set; }
        public virtual DbSet<DataloggerFileColumn> DataloggerFileColumns { get; set; }
        public virtual DbSet<DataLoggerFile> DataLoggerFiles { get; set; }
        public virtual DbSet<DataloggerProgramFile> DataloggerProgramFiles { get; set; }
        public virtual DbSet<DataQuality> DataQualities { get; set; }
        public virtual DbSet<DataSetCitation> DataSetCitations { get; set; }
        public virtual DbSet<DataSet> DataSets { get; set; }
        public virtual DbSet<DataSetsResult> DataSetsResults { get; set; }
        public virtual DbSet<DerivationEquation> DerivationEquations { get; set; }
        public virtual DbSet<Directive> Directives { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<EquipmentAnnotation> EquipmentAnnotations { get; set; }
        public virtual DbSet<EquipmentModel> EquipmentModels { get; set; }
        public virtual DbSet<EquipmentUsed> EquipmentUseds { get; set; }
        public virtual DbSet<ExtensionProperty> ExtensionProperties { get; set; }
        public virtual DbSet<ExternalIdentifierSystem> ExternalIdentifierSystems { get; set; }
        public virtual DbSet<FeatureAction> FeatureActions { get; set; }
        public virtual DbSet<InstrumentOutputVariable> InstrumentOutputVariables { get; set; }
        public virtual DbSet<MaintenanceAction> MaintenanceActions { get; set; }
        public virtual DbSet<MeasurementResult> MeasurementResults { get; set; }
        public virtual DbSet<MeasurementResultValueAnnotation> MeasurementResultValueAnnotations { get; set; }
        public virtual DbSet<MeasurementResultValue> MeasurementResultValues { get; set; }
        public virtual DbSet<MethodAnnotation> MethodAnnotations { get; set; }
        public virtual DbSet<MethodCitation> MethodCitations { get; set; }
        public virtual DbSet<MethodExtensionPropertyValue> MethodExtensionPropertyValues { get; set; }
        public virtual DbSet<MethodExternalIdentifier> MethodExternalIdentifiers { get; set; }
        public virtual DbSet<Method> Methods { get; set; }
        public virtual DbSet<ModelAffiliation> ModelAffiliations { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PersonExternalIdentifier> PersonExternalIdentifiers { get; set; }
        public virtual DbSet<PointCoverageResult> PointCoverageResults { get; set; }
        public virtual DbSet<PointCoverageResultValueAnnotation> PointCoverageResultValueAnnotations { get; set; }
        public virtual DbSet<PointCoverageResultValue> PointCoverageResultValues { get; set; }
        public virtual DbSet<ProcessingLevel> ProcessingLevels { get; set; }
        public virtual DbSet<ProfileResult> ProfileResults { get; set; }
        public virtual DbSet<ProfileResultValueAnnotation> ProfileResultValueAnnotations { get; set; }
        public virtual DbSet<ProfileResultValue> ProfileResultValues { get; set; }
        public virtual DbSet<ReferenceMaterialExternalIdentifier> ReferenceMaterialExternalIdentifiers { get; set; }
        public virtual DbSet<ReferenceMaterial> ReferenceMaterials { get; set; }
        public virtual DbSet<ReferenceMaterialValue> ReferenceMaterialValues { get; set; }
        public virtual DbSet<RelatedAction> RelatedActions { get; set; }
        public virtual DbSet<RelatedAnnotation> RelatedAnnotations { get; set; }
        public virtual DbSet<RelatedCitation> RelatedCitations { get; set; }
        public virtual DbSet<RelatedDataset> RelatedDatasets { get; set; }
        public virtual DbSet<RelatedEquipment> RelatedEquipments { get; set; }
        public virtual DbSet<RelatedFeature> RelatedFeatures { get; set; }
        public virtual DbSet<RelatedModel> RelatedModels { get; set; }
        public virtual DbSet<RelatedResult> RelatedResults { get; set; }
        public virtual DbSet<ResultAnnotation> ResultAnnotations { get; set; }
        public virtual DbSet<ResultExtensionPropertyValue> ResultExtensionPropertyValues { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<ResultsDataQuality> ResultsDataQualities { get; set; }
        public virtual DbSet<ResultTypeCV> ResultTypeCVs { get; set; }
        public virtual DbSet<SamplingFeatureAnnotation> SamplingFeatureAnnotations { get; set; }
        public virtual DbSet<SamplingFeatureExtensionPropertyValue> SamplingFeatureExtensionPropertyValues { get; set; }
        public virtual DbSet<SamplingFeatureExternalIdentifier> SamplingFeatureExternalIdentifiers { get; set; }
        public virtual DbSet<SamplingFeature> SamplingFeatures { get; set; }
        public virtual DbSet<SectionResult> SectionResults { get; set; }
        public virtual DbSet<SectionResultValueAnnotation> SectionResultValueAnnotations { get; set; }
        public virtual DbSet<SectionResultValue> SectionResultValues { get; set; }
        public virtual DbSet<Simulation> Simulations { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SpatialOffset> SpatialOffsets { get; set; }
        public virtual DbSet<SpatialReferenceExternalIdentifier> SpatialReferenceExternalIdentifiers { get; set; }
        public virtual DbSet<SpatialReference> SpatialReferences { get; set; }
        public virtual DbSet<SpecimenBatchPostion> SpecimenBatchPostions { get; set; }
        public virtual DbSet<Specimen> Specimens { get; set; }
        public virtual DbSet<SpecimenTaxonomicClassifier> SpecimenTaxonomicClassifiers { get; set; }
        public virtual DbSet<SpectraResult> SpectraResults { get; set; }
        public virtual DbSet<SpectraResultValueAnnotation> SpectraResultValueAnnotations { get; set; }
        public virtual DbSet<SpectraResultValue> SpectraResultValues { get; set; }
        public virtual DbSet<TaxonomicClassifierExternalIdentifier> TaxonomicClassifierExternalIdentifiers { get; set; }
        public virtual DbSet<TaxonomicClassifier> TaxonomicClassifiers { get; set; }
        public virtual DbSet<TimeSeriesResult> TimeSeriesResults { get; set; }
        public virtual DbSet<TimeSeriesResultValueAnnotation> TimeSeriesResultValueAnnotations { get; set; }
        public virtual DbSet<TimeSeriesResultValue> TimeSeriesResultValues { get; set; }
        public virtual DbSet<TrajectoryResult> TrajectoryResults { get; set; }
        public virtual DbSet<TrajectoryResultValueAnnotation> TrajectoryResultValueAnnotations { get; set; }
        public virtual DbSet<TrajectoryResultValue> TrajectoryResultValues { get; set; }
        public virtual DbSet<TransectResult> TransectResults { get; set; }
        public virtual DbSet<TransectResultValueAnnotation> TransectResultValueAnnotations { get; set; }
        public virtual DbSet<TransectResultValue> TransectResultValues { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<VariableExtensionPropertyValue> VariableExtensionPropertyValues { get; set; }
        public virtual DbSet<VariableExternalIdentifier> VariableExternalIdentifiers { get; set; }
        public virtual DbSet<Variable> Variables { get; set; }

        public IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }

        public void Add<T>(T entity) where T : class
        {
            Set<T>().Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            Entry(entity).State = EntityState.Modified;
        }

        public void Remove<T>(T entity) where T : class
        {
            Set<T>().Remove(entity);
        }
    }
}
