import Loading from '../../../Common/Loading/Loading'
import EmptyPost from '../../EmptyPost/EmptyPost'

function TabContent({ id }) {
    return (
        <div>
            {id}
            {/* <Loading height={300} /> */}
            <EmptyPost height={300} />
        </div>
    )
}

export default TabContent
