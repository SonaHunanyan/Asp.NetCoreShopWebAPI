using System;
using System.Collections.Generic;
using System.Text;
    using EntityRepositoriesByNetCycle.EntityAbstractions;
using EntityRepositoriesByNetCycle.RepositoryAbstraction;

namespace Proj.Dal
{
  public  class Repositories<TEntity>:RepositoryBase<ProjContext, TEntity> where TEntity: class, IEntityBase
    {
        public Repositories(ProjContext context):base(context)
        {

        }
    }
}
